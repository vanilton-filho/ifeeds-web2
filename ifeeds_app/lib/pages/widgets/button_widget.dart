import 'package:flutter/material.dart';

class ButtonWidget extends StatelessWidget {
  final EdgeInsets edgeInsets;
  final String label;
  final double borderCircular;
  final ButtonStyle? buttonStyle;
  final Function()? onPressed;
  final double? width;

  const ButtonWidget({
    Key? key,
    required this.edgeInsets,
    required this.label,
    required this.borderCircular,
    this.buttonStyle,
    this.onPressed,
    this.width,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      width: width != null ? width : 400,
      height: 50,
      child: ElevatedButton(
          onPressed: onPressed, child: Text(label), style: buttonStyle),
    );
  }
}
