import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/pages/user/admin/acoes/acoes_page.dart';

void main() {
  runApp(RootApp());
}

class RootApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: AppColors.primarySwatch,
      ),
      home: Scaffold(
        body: AcoesPage(
          title: 'avaliação',
        ),
      ),
    );
  }
}
