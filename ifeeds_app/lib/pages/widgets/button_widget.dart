import 'package:flutter/material.dart';

class ButtonWidget extends StatelessWidget {
  final EdgeInsets edgeInsets;
  final String label;
  final double borderCircular;
  final ButtonStyle buttonStyle;
  final Function()? onPressed;

  const ButtonWidget({
    Key? key,
    required this.edgeInsets,
    required this.label,
    required this.borderCircular,
    required this.buttonStyle,
    this.onPressed,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      child: ElevatedButton(
          onPressed: onPressed,
          child: Padding(
            padding: edgeInsets,
            child: Text(label),
          ),
          style: buttonStyle),
    );
  }
}
