import 'package:flutter/material.dart';

import 'app_colors.dart';
import 'app_text_styles.dart';

class AppButtonStyles {
  static final ButtonStyle green = ButtonStyle(
    textStyle: MaterialStateProperty.all<TextStyle>(
      AppTextStyles.button,
    ),
    foregroundColor: MaterialStateProperty.all<Color>(Colors.white),
    backgroundColor: MaterialStateProperty.all<Color>(
      AppColors.primarySwatch,
    ),
    shape: MaterialStateProperty.all<RoundedRectangleBorder>(
      RoundedRectangleBorder(
        borderRadius: BorderRadius.circular(8),
      ),
    ),
  );

  static final ButtonStyle grey = ButtonStyle(
    textStyle: MaterialStateProperty.all<TextStyle>(
      AppTextStyles.button,
    ),
    foregroundColor: MaterialStateProperty.all<Color>(Colors.black45),
    backgroundColor: MaterialStateProperty.all<Color>(
      Colors.white,
    ),
    shape: MaterialStateProperty.all<RoundedRectangleBorder>(
      RoundedRectangleBorder(
        side: BorderSide(color: Colors.black45, width: 3),
        borderRadius: BorderRadius.circular(8),
      ),
    ),
  );

  static final ButtonStyle delete = ButtonStyle(
    textStyle: MaterialStateProperty.all<TextStyle>(
      AppTextStyles.button,
    ),
    foregroundColor: MaterialStateProperty.all<Color>(Colors.white),
    backgroundColor: MaterialStateProperty.all<Color>(
      Colors.red,
    ),
  );

  static final ButtonStyle atualizar = ButtonStyle(
    textStyle: MaterialStateProperty.all<TextStyle>(
      AppTextStyles.button,
    ),
    foregroundColor: MaterialStateProperty.all<Color>(Colors.white),
    backgroundColor: MaterialStateProperty.all<Color>(
      Colors.blue,
    ),
  );

  static final ButtonStyle white = ButtonStyle(
    textStyle: MaterialStateProperty.all<TextStyle>(
      AppTextStyles.button,
    ),
    foregroundColor:
        MaterialStateProperty.all<Color>(AppColors.primarySwatch.shade600),
    backgroundColor: MaterialStateProperty.all<Color>(
      Colors.white,
    ),
    shape: MaterialStateProperty.all<RoundedRectangleBorder>(
      RoundedRectangleBorder(
        side: BorderSide(color: AppColors.primarySwatch, width: 3),
        borderRadius: BorderRadius.circular(8),
      ),
    ),
  );
}
