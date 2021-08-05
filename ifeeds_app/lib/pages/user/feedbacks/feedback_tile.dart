import 'package:flutter/material.dart';
import 'package:ifeeds_app/pages/user/feedbacks/widgets/tile_widget.dart';

class FeedbackTile extends StatefulWidget {
  const FeedbackTile({Key? key}) : super(key: key);

  @override
  _FeedbackTileState createState() => _FeedbackTileState();
}

class _FeedbackTileState extends State<FeedbackTile> {
  @override
  Widget build(BuildContext context) {
    return LayoutBuilder(
      builder: (BuildContext ctx, BoxConstraints constraints) {
        if (constraints.maxWidth < 1200) {
          return TileWidget();
        }
        return TileWidget(
          marginRight: 600,
        );
      },
    );
  }
}
