import 'package:flutter/material.dart';
import 'package:ifeeds_app/pages/login/login_page.dart';

class RouterLogin {
  static void routeToLogin(BuildContext context){
    Navigator.push(
      context, MaterialPageRoute(
        builder: (context) => LoginPage()
      )
    );
  }
}