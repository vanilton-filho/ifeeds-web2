import 'package:flutter/material.dart';

import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/pages/user/feedbacks/widgets/tile_widget.dart';

class FeedbackTile extends StatefulWidget {
   final FeedbackModel feedbackModel;
  const FeedbackTile({
    Key? key,
    required this.feedbackModel,
  }) : super(key: key);

  @override
  _FeedbackTileState createState() => _FeedbackTileState();
}

class _FeedbackTileState extends State<FeedbackTile> {
  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(
      builder: (BuildContext ctx, BoxConstraints constraints) {
        if (constraints.maxWidth < 1200) {
          return TileWidget(feedbackModel: widget.feedbackModel,);
        }
        return TileWidget(feedbackModel: widget.feedbackModel,
          marginRight: 600,
        );
      },
    );
  }
}
