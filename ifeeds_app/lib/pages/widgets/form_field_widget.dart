import 'package:flutter/material.dart';

class FormFieldWidget extends StatelessWidget {
  final EdgeInsets edgeInsets;
  final String label;
  final IconData? prefixIcon;
  final bool isPassword;
  final Function(String)? onChanged;
  final String? Function(String?)? validator;

  const FormFieldWidget({
    Key? key,
    required this.edgeInsets,
    required this.label,
    this.prefixIcon,
    this.isPassword = false,
    this.onChanged,
    this.validator,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Padding(
      padding: edgeInsets,
      child: TextFormField(
        autovalidateMode: AutovalidateMode.onUserInteraction,
        validator: validator,
        onChanged: onChanged,
        obscureText: isPassword,
        decoration: InputDecoration(
          prefixIcon: prefixIcon != null ? Icon(prefixIcon) : null,
          labelText: label,
          filled: true,
          fillColor: Colors.white,
          border: OutlineInputBorder(),
        ),
      ),
    );
  }
}
