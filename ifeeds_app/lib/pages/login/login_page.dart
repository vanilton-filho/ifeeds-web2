import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_button_styles.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/models/error_model.dart';
import 'package:ifeeds_app/models/login_model.dart';
import 'package:ifeeds_app/pages/login/widgets/page_image_widget.dart';
import 'package:ifeeds_app/pages/login/widgets/page_view_widget.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page_admin.dart';
import 'package:ifeeds_app/pages/utils/snackbar_utils.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/pages/widgets/link_widget.dart';
import 'package:ifeeds_app/services/login_service.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);

  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  LoginModel _loginModel = new LoginModel();
  final _formKey = GlobalKey<FormState>();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Align(
        alignment: Alignment.topCenter,
        child: ConstrainedBox(
          constraints: BoxConstraints(maxWidth: 1440),
          child: Container(
            color: Colors.white,
            child: Row(
              children: [
                Expanded(
                  flex: 2,
                  child: Container(
                    child: PageViewWidget(
                      totalPages: 3,
                      images: [
                        PageImageWidget(
                          fit: BoxFit.cover,
                          urlImage:
                              'https://images.unsplash.com/photo-1496317899792-9d7dbcd928a1?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                        ),
                        PageImageWidget(
                          fit: BoxFit.cover,
                          urlImage:
                              'https://images.unsplash.com/photo-1494809610410-160faaed4de0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                        ),
                        PageImageWidget(
                          fit: BoxFit.cover,
                          urlImage:
                              'https://images.unsplash.com/photo-1521737711867-e3b97375f902?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                        ),
                      ],
                    ),
                  ),
                ),
                Expanded(
                  flex: 3,
                  child: SingleChildScrollView(
                    child: Container(
                      color: Colors.white,
                      child: Padding(
                        padding: const EdgeInsets.symmetric(horizontal: 100.0),
                        child: Column(
                          children: [
                            Align(
                              alignment: Alignment.topLeft,
                              child: Text(
                                'Acesse sua conta',
                                style: AppTextStyles.heading1,
                              ),
                            ),
                            SizedBox(
                              height: 23,
                            ),
                            Padding(
                              padding: const EdgeInsets.only(bottom: 23.0),
                              child: Align(
                                alignment: Alignment.topLeft,
                                child: Card(
                                  elevation: 8,
                                  shape: RoundedRectangleBorder(
                                    borderRadius: BorderRadius.circular(25),
                                  ),
                                  child: Container(
                                    height: 523,
                                    width: 642,
                                    decoration: BoxDecoration(
                                      borderRadius: BorderRadius.circular(25),
                                      color:
                                          Color.fromRGBO(196, 196, 196, 0.32),
                                    ),
                                    child: Builder(
                                      builder: (context) => Form(
                                        key: _formKey,
                                        child: Column(
                                          children: [
                                            SizedBox(
                                              height: 50,
                                            ),
                                            Padding(
                                              padding:
                                                  const EdgeInsets.symmetric(
                                                      horizontal: 120.0),
                                              child: Text(
                                                'Junte-se à nossa comunidade e ajude a melhorar nosso IFS.',
                                                textAlign: TextAlign.center,
                                                style: AppTextStyles.normal2,
                                              ),
                                            ),
                                            SizedBox(
                                              height: 40,
                                            ),
                                            Padding(
                                              padding:
                                                  const EdgeInsets.symmetric(
                                                      horizontal: 120),
                                              child: FormFieldWidget(
                                                label: 'Matrícula',
                                                validator: (String? val) => (val!
                                                        .isEmpty)
                                                    ? 'Por favor, insira a sua matrícula'
                                                    : null,
                                                onChanged: (val) {
                                                  _loginModel.matricula = val;
                                                },
                                              ),
                                            ),
                                            SizedBox(
                                              height: 33,
                                            ),
                                            Padding(
                                              padding:
                                                  const EdgeInsets.symmetric(
                                                      horizontal: 120),
                                              child: FormFieldWidget(
                                                label: 'Senha',
                                                prefixIcon: Icons.lock,
                                                isPassword: true,
                                                validator: (String? val) => (val!
                                                        .isEmpty)
                                                    ? 'Por favor, insira a sua senha'
                                                    : null,
                                                onChanged: (val) {
                                                  _loginModel.senha = val;
                                                },
                                              ),
                                            ),
                                            SizedBox(
                                              height: 40,
                                            ),
                                            ButtonWidget(
                                              onPressed: () {
                                                final form =
                                                    _formKey.currentState;
                                                if (form!.validate()) {
                                                  _loginAction(_loginModel);
                                                }
                                              },
                                              edgeInsets:
                                                  const EdgeInsets.symmetric(
                                                vertical: 21,
                                                horizontal: 168,
                                              ),
                                              label: 'LOGIN  >',
                                              borderCircular: 8,
                                              buttonStyle:
                                                  AppButtonStyles.green,
                                            ),
                                            SizedBox(
                                              height: 28,
                                            ),
                                            LinkWidget(
                                              text:
                                                  "NÃO POSSUI CONTA? CADASTRE-SE",
                                            ),
                                          ],
                                        ),
                                      ),
                                    ),
                                  ),
                                ),
                              ),
                            ),
                          ],
                        ),
                      ),
                    ),
                  ),
                ),
              ],
            ),
          ),
        ),
      ),
    );
  }

  _loginAction(LoginModel loginModel) async {
    LoginService loginService = LoginService();

    var loginMapPayload = _loginModel.toMap();

    dynamic result = await loginService.login(loginMapPayload);

    if (result is ErrorModel) {
      SnackBarUtils.showSnackbar(
        context,
        result.message!,
        Icon(
          Icons.error,
          color: Colors.white,
        ),
        background: Colors.redAccent,
      );
      return LoginPage();
    }

    String role = result;
    print(role);
    Navigator.of(context).push(MaterialPageRoute(
        builder: (context) =>
            role.toLowerCase() == "admin" ? DrawerPageAdmin() : DrawerPage()));
  }
}
