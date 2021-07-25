import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';
import 'package:ifeeds_app/pages/login/widgets/page_image_widget.dart';
import 'package:ifeeds_app/pages/login/widgets/page_view_widget.dart';
import 'package:ifeeds_app/pages/widgets/button_widget.dart';
import 'package:ifeeds_app/pages/widgets/form_field_widget.dart';
import 'package:ifeeds_app/pages/widgets/link_widget.dart';

class LoginPage extends StatefulWidget {
  const LoginPage({Key? key}) : super(key: key);

  @override
  _LoginPageState createState() => _LoginPageState();
}

class _LoginPageState extends State<LoginPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Container(
        child: Row(
          children: [
            Expanded(
              flex: 2,
              child: Container(
                child: PageViewWidget(
                  totalPages: 3,
                  images: [
                    PageImageWidget(
                      fit: BoxFit.fill,
                      urlImage:
                          'https://images.unsplash.com/photo-1496317899792-9d7dbcd928a1?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                    ),
                    PageImageWidget(
                      fit: BoxFit.fill,
                      urlImage:
                          'https://images.unsplash.com/photo-1494809610410-160faaed4de0?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                    ),
                    PageImageWidget(
                      fit: BoxFit.fill,
                      urlImage:
                          'https://images.unsplash.com/photo-1521737711867-e3b97375f902?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=634&q=80',
                    ),
                  ],
                ),
              ),
            ),
            Expanded(
              flex: 3,
              child: Container(
                color: Colors.white,
                child: Padding(
                  padding: const EdgeInsets.only(left: 100.0),
                  child: Column(
                    children: [
                      SizedBox(
                        height: 42,
                      ),
                      Align(
                        alignment: Alignment.topLeft,
                        child: Text(
                          'Acesse sua conta',
                          style: AppTextStyles.heading1,
                        ),
                      ),
                      SizedBox(
                        height: 42,
                      ),
                      Align(
                        alignment: Alignment.topLeft,
                        child: Container(
                          child: Builder(
                            builder: (context) => Form(
                              child: Column(
                                children: [
                                  SizedBox(
                                    height: 84,
                                  ),
                                  FormFieldWidget(
                                    edgeInsets: EdgeInsets.only(
                                      left: 120,
                                      right: 120,
                                    ),
                                    label: 'Matrícula',
                                  ),
                                  SizedBox(
                                    height: 33,
                                  ),
                                  FormFieldWidget(
                                    edgeInsets: EdgeInsets.only(
                                      left: 120,
                                      right: 120,
                                    ),
                                    label: 'Senha',
                                    prefixIcon: Icons.lock,
                                    isPassword: true,
                                  ),
                                  SizedBox(
                                    height: 40,
                                  ),
                                  ButtonWidget(
                                    edgeInsets: const EdgeInsets.symmetric(
                                      vertical: 21,
                                      horizontal: 168,
                                    ),
                                    label: 'LOGIN >',
                                    borderCircular: 8,
                                  ),
                                  SizedBox(
                                    height: 28,
                                  ),
                                  LinkWidget(
                                    text: "NÃO POSSUI CONTA? CADASTRE-SE",
                                  ),
                                ],
                              ),
                            ),
                          ),
                          height: 523,
                          width: 642,
                          decoration: BoxDecoration(
                            borderRadius: BorderRadius.all(Radius.circular(25)),
                            boxShadow: [
                              BoxShadow(
                                color: Color.fromRGBO(196, 196, 196, 0.22),
                                spreadRadius: -4,
                                offset: Offset(0, 4),
                              ),
                              BoxShadow(
                                color: Color.fromRGBO(196, 196, 196, 0.32),
                                spreadRadius: -8,
                              ),
                            ],
                          ),
                        ),
                      ),
                    ],
                  ),
                ),
              ),
            )
          ],
        ),
      ),
    );
  }
}
