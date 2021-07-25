import 'package:flutter/material.dart';

class AppColors {
  static final Map<int, Color> _color = {
    50: Color.fromRGBO(27, 195, 94, .1),
    100: Color.fromRGBO(27, 195, 94, .2),
    200: Color.fromRGBO(27, 195, 94, .3),
    300: Color.fromRGBO(27, 195, 94, .4),
    400: Color.fromRGBO(27, 195, 94, .5),
    500: Color.fromRGBO(27, 195, 94, .6),
    600: Color.fromRGBO(27, 195, 94, .7),
    700: Color.fromRGBO(27, 195, 94, .8),
    800: Color.fromRGBO(27, 195, 94, .9),
    900: Color.fromRGBO(27, 195, 94, 1),
  };

  static final MaterialColor primarySwatch = MaterialColor(0xff1BC35E, _color);
  static final Color heading1 = Color(0xff39434D);
  static final Color normal = Color(0xff4D5F56);
  static final Color link = Colors.blueAccent;
}
