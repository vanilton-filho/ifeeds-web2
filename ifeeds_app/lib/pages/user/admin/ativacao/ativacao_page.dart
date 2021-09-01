import 'package:flutter/material.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/models/usuario_model.dart';
import 'package:ifeeds_app/services/usuario_service.dart';

class AtivacaoPage extends StatefulWidget {
  const AtivacaoPage({Key? key}) : super(key: key);

  @override
  _AtivacaoPageState createState() => _AtivacaoPageState();
}

class _AtivacaoPageState extends State<AtivacaoPage> {
  _future() async {
    return await UsuarioService().listar();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Colors.white,
      body: Container(
        decoration: BoxDecoration(
            color: Colors.white,
            borderRadius: BorderRadius.only(
              topLeft: Radius.circular(27.0),
              topRight: Radius.circular(27.0),
            )),
        child: FutureBuilder(
          future: _future(),
          builder: (context, AsyncSnapshot<dynamic> snapshot) {
            if (snapshot.hasData) {
              List<UsuarioModel> usuarios = snapshot.data!;
              return RefreshIndicator(
                onRefresh: _refreshUsuarios,
                child: ListView.builder(
                    scrollDirection: Axis.vertical,
                    itemCount: usuarios.length,
                    itemBuilder: (context, index) {
                      final usuarioAtivo = usuarios[index];
                      return SwitchListTile(
                          title: Text(
                            '@${usuarioAtivo.nome} | ${usuarioAtivo.matricula}',
                            style: GoogleFonts.sourceSansPro(fontSize: 21.0),
                          ),
                          value: usuarioAtivo.status!,
                          onChanged: (value) =>
                              _ativaOuDesativa(value, usuarioAtivo));
                    }),
              );
            } else if (snapshot.hasError) {
              return Column(
                mainAxisAlignment: MainAxisAlignment.center,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Icon(
                    Icons.error,
                    color: Colors.red,
                    size: 68.0,
                  ),
                  Text(
                    '${snapshot.error}',
                    style: GoogleFonts.sourceSansPro(
                      fontSize: 16.0,
                    ),
                    textAlign: TextAlign.center,
                  ),
                  Text(
                    'Ops... algo de errado aconteceu, tente novamente em alguns instantes.',
                    style: GoogleFonts.sourceSansPro(
                      fontSize: 16.0,
                    ),
                    textAlign: TextAlign.center,
                  ),
                ],
              );
            }

            return Center(
              child: CircularProgressIndicator(),
            );
          },
        ),
      ),
    );
  }

  Future<void> _refreshUsuarios() async {
    setState(() {
      UsuarioService().listar();
    });
  }

  _ativaOuDesativa(bool value, UsuarioModel usuario) async {
    bool? isOk;
    if (value)
      isOk = await UsuarioService().ativar(usuario.matricula!);
    else
      isOk = await UsuarioService().desativar(usuario.matricula!);

    if (isOk!) {
      setState(() {
        usuario.status = value;
      });
    }
  }
}
