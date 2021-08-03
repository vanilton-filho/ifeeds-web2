import 'dart:ui';

import 'package:flutter/material.dart';

class SnackBarUtils {
  static void showSnackbar(BuildContext context, String message, Icon icon,
      {Color background = Colors.black, double width = 500}) {
    var snackbar = SnackBar(
      width: width,
      behavior: SnackBarBehavior.floating,
      backgroundColor: background,
      duration: Duration(seconds: 5),
      shape: RoundedRectangleBorder(borderRadius: BorderRadius.circular(100)),
      content: Container(
        height: 25.0,
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 12.0),
          child: Row(
            children: [
              Padding(
                padding: EdgeInsets.symmetric(horizontal: 5.0),
                child: icon,
              ),
              Text(
                message,
              ),
            ],
          ),
        ),
      ),
    );

    ScaffoldMessenger.of(context)..showSnackBar(snackbar);
  }
}
