import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/usuario_model.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedbacks_page.dart';
import 'package:ifeeds_app/pages/user/home/home_page.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';
import 'package:ifeeds_app/services/usuario_service.dart';

class DrawerPage extends StatefulWidget {
  const DrawerPage({Key? key}) : super(key: key);

  @override
  _DrawerPageState createState() => _DrawerPageState();
}

class _DrawerPageState extends State<DrawerPage> {
  int _selectedIndex = 0;
  GetStorage storage = GetStorage();

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
      future: _future(),
      builder: (context, AsyncSnapshot<dynamic> snapshot) {
        if (snapshot.hasData) {
          UsuarioModel usuarioModel = snapshot.data!;
          return Scaffold(
              drawer: Drawer(
                child: ListView(
                  padding: EdgeInsets.zero,
                  children: <Widget>[
                    UserAccountsDrawerHeader(
                        accountName: Text(
                          "${usuarioModel.nome}",
                          style: GoogleFonts.sourceSansPro(fontSize: 21),
                        ),
                        accountEmail: Text(
                          "${usuarioModel.contato!.email}",
                          style: GoogleFonts.sourceSansPro(fontSize: 18),
                        ),
                        currentAccountPicture: CircleAvatar(
                          child: Icon(
                            Icons.account_circle,
                            size: 60,
                            color: Colors.white,
                          ),
                          radius: 30.0,
                        )),
                    ListTile(
                      selected: 0 == _selectedIndex,
                      leading: Icon(Icons.home),
                      title: Text('Home'),
                      onTap: () => _onSelectItem(0),
                    ),
                    ListTile(
                      selected: 1 == _selectedIndex,
                      leading: Icon(Icons.feedback),
                      title: Text('Feedbacks'),
                      subtitle: Text('Histórico de Feedbacks'),
                      onTap: () => _onSelectItem(1),
                    ),
                  ],
                ),
              ),
              appBar: AppBar(
                actions: [
                  Row(
                    crossAxisAlignment: CrossAxisAlignment.center,
                    children: [
                      Padding(
                        padding: const EdgeInsets.only(right: 26.0 / 2),
                        child: Text(
                          "${usuarioModel.contato!.email}",
                          style: AppTextStyles.normal2,
                        ),
                      ),
                      Padding(
                          padding: const EdgeInsets.only(right: 26.0),
                          child: PopupMenuButton<int>(
                              itemBuilder: (context) => [
                                    PopupMenuItem<int>(
                                      value: 2,
                                      child: Row(
                                        children: [
                                          Icon(
                                            Icons.logout,
                                            color: Colors.red,
                                          ),
                                          const SizedBox(
                                            width: 7,
                                          ),
                                          Text("Logout")
                                        ],
                                      ),
                                    ),
                                  ],
                              onSelected: (item) async {
                                if (item == 2) {
                                  GetStorage storage = GetStorage();
                                  await storage.erase();
                                  Navigator.pushReplacementNamed(context, '/');
                                }
                              },
                              icon: Icon(
                                Icons.account_circle,
                              ))),
                    ],
                  ),
                ],
                iconTheme: IconThemeData(
                  color: Colors.white,
                ),
                bottom: PreferredSize(
                  preferredSize: Size.fromHeight(80.0),
                  child: Container(
                    color: Colors.white,
                    height: 80.0,
                  ),
                ),
              ),
              body: _getDrawerPage(_selectedIndex));
        }
        return Center(
          child: CircularProgressIndicator(),
        );
      },
    );
  }

  _future() async {
    if (JwtUtils.isExpired(storage)) {
      RouterLogin.routeToLogin(context);
    } else {
      return await UsuarioService().getPorMatricula(storage.read("matricula"));
    }
  }

  _onSelectItem(int index) {
    setState(() => _selectedIndex = index);
    Navigator.of(context).pop();
  }

  _getDrawerPage(int pos) {
    switch (pos) {
      case 0:
        return HomePage();
      case 1:
        return FeedbacksPage();
    }
  }
}
