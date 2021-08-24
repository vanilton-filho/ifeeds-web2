import 'package:flutter/material.dart';
import 'package:get/get.dart';

import 'package:ifeeds_app/core/app_text_styles.dart';

class LinkWidget extends StatefulWidget {
  final String text;
  final Function()? onTap;

  const LinkWidget({
    Key? key,
    required this.text,
    this.onTap,
  }) : super(key: key);

  @override
  _LinkWidgetState createState() => _LinkWidgetState();
}

class _LinkWidgetState extends State<LinkWidget> {
  TextStyle textStyle = AppTextStyles.normal;

  @override
  Widget build(BuildContext context) {
    return InkWell(
      onTap: widget.onTap,
      onHover: (value) {
        setState(() {
          value == true
              ? textStyle = AppTextStyles.link
              : textStyle = AppTextStyles.normal;
        });
      },
      child: Text(
        widget.text,
        style: textStyle,
      ),
    );
  }
}
