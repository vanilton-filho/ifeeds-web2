import 'package:flutter/material.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedback_tile.dart';

class FeedbacksPage extends StatefulWidget {
  const FeedbacksPage({Key? key}) : super(key: key);

  @override
  _FeedbacksPageState createState() => _FeedbacksPageState();
}

class _FeedbacksPageState extends State<FeedbacksPage> {
  @override
  Widget build(BuildContext context) {
    return ListView(
      children: [
        FeedbackTile(),
        FeedbackTile(),
        FeedbackTile(),
        FeedbackTile(),
        FeedbackTile(),
        FeedbackTile(),
        FeedbackTile(),
      ],
    );
  }
}
