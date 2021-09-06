import 'package:flutter/material.dart';
import 'package:get_storage/get_storage.dart';
import 'package:google_fonts/google_fonts.dart';
import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/pages/user/feedbacks/feedback_tile.dart';
import 'package:ifeeds_app/pages/widgets/error_app_widget.dart';
import 'package:ifeeds_app/pages/widgets/router_login.dart';
import 'package:ifeeds_app/services/feedback_service.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class FeedbacksPage extends StatefulWidget {
  const FeedbacksPage({Key? key}) : super(key: key);

  @override
  _FeedbacksPageState createState() => _FeedbacksPageState();
}

class _FeedbacksPageState extends State<FeedbacksPage> {
  GetStorage storage = GetStorage();

  @override
  Widget build(BuildContext context) {
    return FutureBuilder(
        future: _future(),
        builder: (context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
            List<FeedbackModel> feedbacksModel = snapshot.data!;
            return !feedbacksModel.isEmpty
                ? ListView(
                    children: feedbacksModel
                        .map((e) => FeedbackTile(
                              feedbackModel: e,
                            ))
                        .toList(),
                  )
                : Center(
                    child: Column(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        Icon(
                          Icons.history_edu,
                          size: 101.0,
                          color: Colors.grey,
                        ),
                        Text(
                          'Nenhum histórico até o momento...',
                          style: GoogleFonts.sourceSansPro(
                            fontSize: 21.0,
                          ),
                        )
                      ],
                    ),
                  );
          } else if (snapshot.hasError) {
            return ErrorAppWidget(message: "Error API");
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

  _future() async {
    if (JwtUtils.isExpired(storage)) {
      RouterLogin.routeToLogin(context);
    } else {
      return await FeedbackService()
          .listarFeedback((int.parse(storage.read(("id")))));
    }
  }
}
