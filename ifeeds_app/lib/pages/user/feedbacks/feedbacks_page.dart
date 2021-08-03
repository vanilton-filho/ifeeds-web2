import 'package:flutter/material.dart';

class FeedbacksPage extends StatefulWidget {
  const FeedbacksPage({Key? key}) : super(key: key);

  @override
  _FeedbacksPageState createState() => _FeedbacksPageState();
}

class _FeedbacksPageState extends State<FeedbacksPage> {
  @override
  Widget build(BuildContext context) {
    return Container(
      child: Center(
        child: Text('Feedbacks'),
      ),
    );
  }
}
