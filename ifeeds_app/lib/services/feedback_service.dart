import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/feedback_model.dart';

import 'envs.dart';

class FeedbackService {
  GetStorage storage = GetStorage();
  late final token;

  FeedbackService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> listarFeedback(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/feedbacks/usuario/$id");
    try {
      final response = await http.get(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

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

  Future<dynamic> listar() async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/feedbacks");
    try {
      final response = await http.get(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

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

  Future<dynamic> getPorMatricula(String codigo) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/feedbacks/usuario/$codigo");
    try {
      final response = await http.get(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

      if (response.statusCode == 200) {
        return FeedbackModel.fromJson(response.body);
      }
    } catch (e) {
      throw new Exception("Impossível obter feedback");
    }
  }

  Future<dynamic> postFormulario(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/feedbacks");
    try {
      print(convert.json.encode(payload));
      final response = await http.post(uri,
          headers: {
            "Accept": "application/json",
            HttpHeaders.authorizationHeader: "Bearer $token",
            HttpHeaders.contentTypeHeader: "application/json"
          },
          body: convert.json.encode(payload));

      if (response.statusCode == 200) {
        return FeedbackModel.fromJson(response.body);
      }
    } catch (e) {
      throw new Exception("Impossível salvar formulário");
    }
  }
}
