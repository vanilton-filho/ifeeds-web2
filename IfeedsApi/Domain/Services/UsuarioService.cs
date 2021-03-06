using System;
using System.Collections.Generic;
using System.Linq;
using IfeedsApi.Api.Mappers;
using IfeedsApi.Api.Models;
using IfeedsApi.Core.Database;
using IfeedsApi.Domain.Models;

namespace IfeedsApi.Services
{
    public class UsuarioService
    {
        private readonly ApplicationDbContext _context;
        private readonly UsuarioMapper _usuarioMapper;

        public UsuarioService(ApplicationDbContext context, UsuarioMapper usuarioMapper)
        {
            _context = context;
            _usuarioMapper = usuarioMapper;
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

        public void Ativar(Usuario usuario)
        {
            usuario.Status = true;
            _context.Update(usuario);
            _context.SaveChanges();
        }

        public void Desativar(Usuario usuario)
        {
            usuario.Status = false;
            _context.Update(usuario);
            _context.SaveChanges();
        }

        public Usuario SaveUsuario(Usuario usuario, Contato contato, int campusId, int tipoConta)
        {
            // var usuario = _mapper.Map<Usuario>(request);
            // var contato = _mapper.Map<Contato>(request);

            // É importante considerarmos que pode haver um erro
            // no meio do caminho, então vamos garantir o rollback de
            // tudo o que ocorrer até o commit
            using var transaction = _context.Database.BeginTransaction(); // início da transação

            _context.Add(contato);
            _context.SaveChanges();

            // Atribuindo IDs das entidades Contato e Role
            usuario.ContatoId = contato.Id;
            // TODO: Definir lógica para o tipo de usuário
            if ((int)TipoRole.USER == tipoConta)
            {
                usuario.Status = true;
            }

            usuario.RoleId = tipoConta;
            usuario.CampusId = campusId;


            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            _context.Add(usuario);
            _context.SaveChanges();

            transaction.Commit(); // fim da transação
            return usuario;
        }

        public void UpdateUsuario(Usuario usuario)
        {
            using var transaction = _context.Database.BeginTransaction(); // início da transação
            _context.Update(usuario);
            _context.SaveChanges();
            transaction.Commit(); // fim da transação
        }

        public Usuario FindByMatricula(string matricula)
        {
            var usuario = _context.Usuarios
                .Where(e => e.Matricula == matricula)
                .FirstOrDefault();

            return usuario;
        }

        public Usuario AutenticarUsuario(string matricula, string senha)
        {
            var usuario = _context.Usuarios
                .Where(e => e.Matricula == matricula)
                .FirstOrDefault();

            return (usuario != null) && CheckSenha(senha, usuario) ? usuario : null;
        }

        public bool CheckSenha(string senhaReq, Usuario usuario)
        {
            return BCrypt.Net.BCrypt.Verify(senhaReq, usuario.Senha) ? true : false;
        }

        public Usuario BuscarAdminPorId(int usuarioId)
        {
            return _context.Usuarios.Where(u => u.Id == usuarioId && u.RoleId == ((int)TipoRole.ADMIN)).FirstOrDefault();
        }

        public Usuario GetPorId(int usuarioId)
        {
            return _context.Usuarios.Find(usuarioId);
        }

        public bool AlterarSenha(string senhaAtual, string novaSenha, string matricula)
        {
            var usuario = _context.Usuarios.Where(u => u.Matricula.Equals(matricula)).FirstOrDefault();

            if (usuario == null)
            {
                throw new Exception("Usuário não encontrado!");
            }
            var senhaVerificada = CheckSenha(senhaAtual, usuario);

            if (senhaVerificada)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(novaSenha);
                usuario.DataAtualizacao = DateTime.Now;
                _context.Update(usuario);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

    }
}