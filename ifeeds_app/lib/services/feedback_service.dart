import 'package:ifeeds_app/models/feedback_model.dart';

import 'envs.dart';
import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class FeedbackService {
  
  static Future<dynamic> listarFeedback() async {
    Uri uri = Uri.http(Envs.baseUrl, "api/feedbacks");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<FeedbackModel>((json) => FeedbackModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar feedbacks");
    }
  }
}