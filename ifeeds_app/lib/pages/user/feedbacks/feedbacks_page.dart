import 'package:flutter/material.dart';
import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedback_tile.dart';
import 'package:ifeeds_app/pages/widgets/error_app_widget.dart';
import 'package:ifeeds_app/services/feedback_service.dart';

class FeedbacksPage extends StatefulWidget {
  const FeedbacksPage({Key? key}) : super(key: key);

  @override
  _FeedbacksPageState createState() => _FeedbacksPageState();
}

class _FeedbacksPageState extends State<FeedbacksPage> {
  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: FeedbackService.listarFeedback(),
        builder: (context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
            List<FeedbackModel> feedbacksModel = snapshot.data!;
            return ListView(
              children: feedbacksModel
                  .map((e) => FeedbackTile(
                        feedbackModel: e,
                      ))
                  .toList(),
            );
          } else if(snapshot.hasError) {
            return ErrorAppWidget(message: "error");
          }
          return Center(
            child: Row(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                CircularProgressIndicator(),
              ],
            ),
          );
        });
  }
}
