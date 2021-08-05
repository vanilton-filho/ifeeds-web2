import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';

class ErrorAppWidget extends StatefulWidget {
  final String message;

  const ErrorAppWidget({
    Key? key,
    required this.message,
  }) : super(key: key);

  @override
  _ErrorAppWidgetState createState() => _ErrorAppWidgetState();
}

class _ErrorAppWidgetState extends State<ErrorAppWidget> {
  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: const EdgeInsets.symmetric(horizontal: 8.0),
      child: Center(
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Icon(
              Icons.error,
              color: Colors.red,
              size: 68.0,
            ),
            Text(
              widget.message,
              style: AppTextStyles.normal,
              textAlign: TextAlign.center,
            ),
            Text(
              'Ops... algo de errado aconteceu, tente novamente em alguns instantes.',
              style: AppTextStyles.normal,
              textAlign: TextAlign.center,
            ),
          ],
        ),
      ),
    );
  }
}
