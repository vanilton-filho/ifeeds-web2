import 'package:flutter/material.dart';
import 'package:flutter/scheduler.dart';

class RouterLogin {
  static void routeToLogin(BuildContext context) {
    SchedulerBinding.instance!.addPostFrameCallback((_) {
      Navigator.of(context).pushReplacementNamed('/');
    });
  }
}
