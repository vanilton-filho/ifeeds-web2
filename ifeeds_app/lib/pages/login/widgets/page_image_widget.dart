import 'package:flutter/material.dart';

class PageImageWidget extends StatelessWidget {
  final Color? color;
  final BoxFit fit;
  final String urlImage;

  const PageImageWidget({
    Key? key,
    this.color,
    required this.fit,
    required this.urlImage,
  }) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Container(
      color: color != null ? color : Colors.transparent,
      child: FittedBox(
        fit: fit,
        child: Image(
          image: NetworkImage(
            urlImage,
          ),
        ),
      ),
    );
  }
}
