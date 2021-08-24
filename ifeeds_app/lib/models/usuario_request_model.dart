import 'dart:convert';

class UsuarioRequestModel {

  String? matricula;
  String? nome;
  String? email;
  String? telefone;
  String? senha;
  int? campusId;
  int? tipoConta;

  UsuarioRequestModel({
    this.matricula,
    this.nome,
    this.email,
    this.telefone,
    this.senha,
    this.campusId,
    this.tipoConta,
  });


  Map<String, dynamic> toMap() {
    return {
      'matricula': matricula,
      'nome': nome,
      'email': email,
      'telefone': telefone,
      'senha': senha,
      'campusId': campusId,
      'tipoConta': tipoConta,
    };
  }

  factory UsuarioRequestModel.fromMap(Map<String, dynamic> map) {
    return UsuarioRequestModel(
      matricula: map['matricula'],
      nome: map['nome'],
      email: map['email'],
      telefone: map['telefone'],
      senha: map['senha'],
      campusId: map['campusId'],
      tipoConta: map['tipoConta'],
    );
  }

  String toJson() => json.encode(toMap());

  factory UsuarioRequestModel.fromJson(String source) => UsuarioRequestModel.fromMap(json.decode(source));
}
