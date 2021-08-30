import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;

import 'package:ifeeds_app/models/resposta_feedback_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class RespostaFeedbackService {
  GetStorage storage = GetStorage();
  late final token;

  RespostaFeedbackService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> listaRespostasFeedbacks() async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/respostas-feedbacks");
    try {
      final response =
          await http.get(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<RespostaFeedbackModel>((json) => RespostaFeedbackModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar Respostas Feedbacks");
    }
  }

  Future<dynamic> criarRespostaFeedbacks(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbacks");
    try {
      final response = await http.post(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token",
        HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 201) {
        final json = convert.json.decode(response.body);
        return RespostaFeedbackModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível criar respostas feedbacks");
    }
  }

  Future<dynamic> atualizarRespostaFeedbacks(int id, Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbacks/$id");
    try {
      final response = await http.put(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token",
        HttpHeaders.contentTypeHeader: "application/json"
      }, body: convert.json.encode(payload));

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return RespostaFeedbackModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar respostas feedbcaks");
    }
  }

Future<dynamic> deletarRespostaFeedbcaks(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbcaks/$id");
    try {
      final response = await http.delete(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar respostas feedbcaks");
    }
  }
}
