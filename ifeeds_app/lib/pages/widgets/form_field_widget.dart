import 'package:flutter/material.dart';
import 'package:flutter/services.dart';

class FormFieldWidget extends StatelessWidget {
  final String? initialValue;
  final String label;
  final IconData? prefixIcon;
  final bool isPassword;
  final bool? isExpanded;
  final Function(String)? onChanged;
  final String? Function(String?)? validator;
  final double? width;
  final TextInputType? type;
  final List<TextInputFormatter>? masks;

  const FormFieldWidget(
      {Key? key,
      required this.label,
      this.initialValue,
      this.prefixIcon,
      this.isPassword = false,
      this.onChanged,
      this.validator,
      this.width,
      this.type,
      this.masks,
      this.isExpanded})
      : super(key: key);

  const FormFieldWidget.expanded(
      {Key? key,
      required this.label,
      this.initialValue,
      this.prefixIcon,
      this.isPassword = false,
      this.onChanged,
      this.validator,
      this.width,
      this.type,
      this.masks,
      this.isExpanded = true})
      : super(key: key);

  @override
  Widget build(BuildContext context) {
    return isExpanded != null && isExpanded == true
        ? Expanded(child: _buildTextFormField())
        : _buildTextFormField();
  }

  _buildTextFormField() {
    return Padding(
      padding: const EdgeInsets.all(8.0),
      child: SizedBox(
        width: width == null ? 100 : width,
        child: TextFormField(
          inputFormatters: masks,
          autovalidateMode: AutovalidateMode.onUserInteraction,
          validator: validator,
          onChanged: onChanged,
          obscureText: isPassword,
          keyboardType: type,
          initialValue: initialValue,
          decoration: InputDecoration(
            prefixIcon: prefixIcon != null ? Icon(prefixIcon) : null,
            labelText: label,
            filled: true,
            fillColor: Colors.white,
            border: OutlineInputBorder(),
          ),
        ),
      ),
    );
  }
}
