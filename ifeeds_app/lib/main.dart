import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/pages/login/login_page.dart';

void main() {
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: AppColors.primarySwatch,
      ),
      home: LoginPage(),
    );
  }
}
