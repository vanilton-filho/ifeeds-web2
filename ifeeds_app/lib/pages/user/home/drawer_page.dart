import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedbacks_page.dart';
import 'package:ifeeds_app/pages/user/home/home_page.dart';
import 'package:ifeeds_app/pages/utils/storage_util.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';

class DrawerPage extends StatefulWidget {
  const DrawerPage({Key? key}) : super(key: key);

  @override
  _DrawerPageState createState() => _DrawerPageState();
}

class _DrawerPageState extends State<DrawerPage> {
  int _selectedIndex = 0;
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        drawer: Drawer(
            child: ListView(
          padding: EdgeInsets.zero,
          children: <Widget>[
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
              onTap: () => _onSelectItem(1),
            ),
            ListTile(
              leading: Icon(Icons.person),
              title: Text('Perfil'),
              onTap: () => {Navigator.of(context).pop()},
            ),
            ListTile(
              leading: Icon(Icons.help),
              title: Text('Ajuda'),
              onTap: () => {Navigator.of(context).pop()},
            ),
          ],
        )),
        appBar: AppBar(
          actions: [
            Row(
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Padding(
                  padding: const EdgeInsets.only(right: 26.0 / 2),
                  child: Text(
                    StorageUtil.getString('email'),
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
                        onSelected: (item) => {},
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
              child: Padding(
                padding: const EdgeInsets.symmetric(
                    vertical: 29.0 / 2, horizontal: 19.0),
                child: Row(
                  mainAxisAlignment: MainAxisAlignment.end,
                  children: [
                    ButtonWidget(
                      onPressed: () => {},
                      edgeInsets: const EdgeInsets.symmetric(
                        vertical: 10.5,
                        horizontal: 48,
                      ),
                      label: 'Novo Feedback  +',
                      borderCircular: 8,
                      buttonStyle: AppButtonStyles.white,
                    )
                  ],
                ),
              ),
            ),
          ),
        ),
        body: _getDrawerPage(_selectedIndex));
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
