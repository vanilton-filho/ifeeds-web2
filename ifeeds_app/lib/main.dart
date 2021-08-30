import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/pages/user/admin/acoes/acoes_page.dart';
import 'package:ifeeds_app/pages/user/admin/home_admin_page.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page.dart';
import 'package:ifeeds_app/pages/user/home/drawer_page_admin.dart';

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
      home: DrawerPageAdmin()
    );
  }
}
