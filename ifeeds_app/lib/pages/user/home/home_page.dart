import 'package:flutter/material.dart';
import 'package:ifeeds_app/pages/user/home/widgets/list_category_widget.dart';

class HomePage extends StatelessWidget {
  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return ListView(
      scrollDirection: Axis.vertical,
      shrinkWrap: true,
      itemExtent: 350,
      children: [
        Padding(
          padding: const EdgeInsets.only(top: 18.0, left: 24.0),
          child: ListCategoryWidget(
            category: 1,
          ),
        ),
        Padding(
          padding: const EdgeInsets.only(top: 18.0, left: 24.0),
          child: ListCategoryWidget(
            category: 2,
          ),
        ),
        Padding(
          padding: const EdgeInsets.only(top: 18.0, left: 24.0),
          child: ListCategoryWidget(
            category: 3,
          ),
        ),
      ],
    );
  }
}
