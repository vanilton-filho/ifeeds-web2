import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/pages/login/login_page.dart';
import 'package:ifeeds_app/pages/user/admin/acoes/acoes_page.dart';
import 'package:ifeeds_app/pages/user/admin/ativacao/ativacao_page.dart';
import 'package:ifeeds_app/pages/user/cadastro/cadastro_usuario_page.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedbacks_page.dart';
import 'package:ifeeds_app/pages/user/formulario/formulario_avaliacao_page.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page_admin.dart';
import 'package:ifeeds_app/pages/user/resposta_feedback/resposta_feedback_page.dart';
import 'package:ifeeds_app/pages/user/resposta_feedback/resposta_formulario.dart';

void main() {
  runApp(RootApp());
}

class RootApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        title: 'IFeedS',
        initialRoute: '/',
        routes: {
          '/': (context) => LoginPage(),
          '/usuario': (context) => DrawerPage(),
          '/admin': (context) => DrawerPageAdmin(),
          '/acoes': (context) => AcoesPage(),
          '/ativacao': (context) => AtivacaoPage(),
          '/cadastro': (context) => const CadastroUsuarioPage(),
          '/feedbacks': (context) => FeedbacksPage(),
          '/formulario-feedback': (context) => FormularioAvaliacaoPage(),
          '/resposta': (context) => RespostaFeedbackPage(),
          '/resposta-formulario': (context) => RespostaFormulario(),
        },
        theme: ThemeData(
          primarySwatch: AppColors.primarySwatch,
        ));
  }
}
