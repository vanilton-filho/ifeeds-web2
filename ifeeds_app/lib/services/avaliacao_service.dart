import 'dart:convert' as convert;
import 'dart:io';

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class AvaliacaoService {
  static Future<dynamic> listarAvaliacoes() async {
    Uri uri = Uri.http(Envs.baseUrl, "api/avaliacoes");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<AvaliacaoModel>((json) => AvaliacaoModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar de avaliações");
    }
  }

  static Future<dynamic> listarAvaliacoesPorCategoria(int categoria) async {
    Uri uri = Uri.http(Envs.baseUrl, "api/avaliacoes/$categoria/por-categoria");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<AvaliacaoModel>((json) => AvaliacaoModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar as avaliações por categoria");
    }
  }

  static Future<dynamic> criarAvaliacao(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacoes");
    try {
      final response = await http.post(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 201) {
        final json = convert.json.decode(response.body);
        return AvaliacaoModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível criar avaliação");
    }
  }

  static Future<dynamic> atualizarAvaliacao(
      Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacao");
    try {
      final response = await http.put(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return AvaliacaoModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar atualização");
    }
  }

  static Future<dynamic> deletarAvaliacao(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacao/{id}");
    try {
      final response = await http.delete(uri);

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar avaliação");
    }
  }
}
