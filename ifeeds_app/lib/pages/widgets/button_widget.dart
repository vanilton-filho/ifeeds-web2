import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_colors.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';

class ButtonWidget extends StatelessWidget {
  final EdgeInsets edgeInsets;
  final String label;
  final double borderCircular;

  const ButtonWidget({
    Key? key,
    required this.edgeInsets,
    required this.label,
    required this.borderCircular,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: ElevatedButton(
        onPressed: () {},
        child: Padding(
          padding: edgeInsets,
          child: Text(
            label,
            style: AppTextStyles.button,
          ),
        ),
        style: ButtonStyle(
          backgroundColor: MaterialStateProperty.all<Color>(
            AppColors.primarySwatch,
          ),
          shape: MaterialStateProperty.all<RoundedRectangleBorder>(
            RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(borderCircular),
            ),
          ),
        ),
      ),
    );
  }
}
