import 'package:flutter/material.dart';
import 'package:ifeeds_app/core/app_text_styles.dart';

class CardGridView extends StatelessWidget {
  final dynamic value;
  final String? label;
  final Color? color;

  const CardGridView({
    Key? key,
    this.value,
    this.label,
    this.color,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      decoration: BoxDecoration(
        borderRadius: BorderRadius.all(
          Radius.circular(15.0),
        ),
        color: color,
      ),
      child: Padding(
        padding: const EdgeInsets.all(16.0),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          mainAxisAlignment: MainAxisAlignment.center,
          children: [
            Padding(
              padding: const EdgeInsets.symmetric(vertical: 8.0),
              child: Text(
                '$value',
              style: AppTextStyles.heading1.merge(TextStyle(fontSize: 40, color: Colors.white)),
              ),
            ),
            Text(
              '$label',
              style: AppTextStyles.heading1.merge(TextStyle(fontSize: 23, color: Colors.white)),
            ),
          ],
        ),
      ),
    );
  }
}
