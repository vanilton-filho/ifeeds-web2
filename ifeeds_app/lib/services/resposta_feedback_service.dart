import 'dart:convert' as convert;
import 'dart:io';

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/resposta_feedback_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class RespostaFeedbackService {
  static Future<dynamic> listaRespostasFeedbacks() async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/respostas-feedbacks");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

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

  static Future<dynamic> criarRespostaFeedbacks(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbcaks");
    try {
      final response = await http.post(uri, headers: {
        HttpHeaders.acceptHeader:"application/json", HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 201) {
        final json = convert.json.decode(response.body);
        return RespostaFeedbackModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível criar respostas feedbacks");
    }
  }

  static Future<dynamic> atualizarRespostaFeedbacks(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbcaks");
    try {
      final response = await http.put(uri, headers: {
        HttpHeaders.acceptHeader:"application/json", HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return RespostaFeedbackModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar respostas feedbcaks");
    }
  }

static Future<dynamic> deletarRespostaFeedbcaks(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/resposta-feedbcaks/{id}");
    try {
      final response = await http.delete(uri);

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar respostas feedbcaks");
    }
  }
}
