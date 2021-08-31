import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/usuario_model.dart';
import 'package:ifeeds_app/pages/login/login_page.dart';
import 'package:ifeeds_app/pages/user/admin/acoes/acoes_page.dart';
import 'package:ifeeds_app/pages/user/admin/home_admin_page.dart';
import 'package:ifeeds_app/services/usuario_service.dart';

class DrawerPageAdmin extends StatefulWidget {
  const DrawerPageAdmin({Key? key}) : super(key: key);

  @override
  _DrawerPageAdminState createState() => _DrawerPageAdminState();
}

class _DrawerPageAdminState extends State<DrawerPageAdmin> {
  GetStorage storage = GetStorage();
  int _selectedIndex = 0;
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
                        accountName: Text("${usuarioModel.nome}"),
                        accountEmail: Text("${usuarioModel.contato!.email}"),
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
                      title: Text('Ações'),
                      onTap: () => _onSelectItem(1),
                    ),
                    ListTile(
                      leading: Icon(Icons.person),
                      title: Text('Perfil'),
                      subtitle: Text('Configurações do usuário'),
                      onTap: () => {Navigator.of(context).pop()},
                    ),
                    ListTile(
                      leading: Icon(Icons.help),
                      title: Text('Ajuda'),
                      onTap: () => {Navigator.of(context).pop()},
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
                                      value: 0,
                                      child: Text("Configurações"),
                                    ),
                                    PopupMenuItem<int>(
                                      value: 1,
                                      child: Text("Políticas de Privacidade"),
                                    ),
                                    PopupMenuDivider(),
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
                              onSelected: (item) {
                                if (item == 2) {
                                  GetStorage storage = GetStorage();
                                  storage.erase();
                                  Navigator.push(
                                      context,
                                      MaterialPageRoute(
                                          builder: (context) => LoginPage()));
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
    return await UsuarioService().getPorMatricula(storage.read("matricula"));
  }

  _onSelectItem(int index) {
    setState(() => _selectedIndex = index);
    Navigator.of(context).pop();
  }

  _getDrawerPage(int pos) {
    switch (pos) {
      case 0:
        return HomeAdminPage();
      case 1:
        return AcoesPage();
    }
  }
}
