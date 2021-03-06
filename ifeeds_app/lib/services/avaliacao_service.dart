import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;

import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/services/envs.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class AvaliacaoService {
  GetStorage storage = GetStorage();
  late final token;

  AvaliacaoService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> listarAvaliacoes() async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacoes");
      try {
        final response = await http.get(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

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
    return true;
  }

  Future<dynamic> listarAvaliacoesPorCategoria(int categoria) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri =
          Uri.http(Envs.baseUrl, "v1/api/avaliacoes/$categoria/por-categoria");
      try {
        final response = await http.get(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

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
    return true;
  }

  Future<dynamic> criarAvaliacao(Map<String, dynamic> payload) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacoes");
      try {
        final response = await http.post(uri,
            headers: {
              "Accept": "application/json",
              HttpHeaders.authorizationHeader: "Bearer $token",
              HttpHeaders.contentTypeHeader: "application/json"
            },
            body: convert.json.encode(payload));
        if (response.statusCode == 201) {
          return AvaliacaoModel.fromJson(response.body);
        }
      } catch (e) {
        throw new Exception("Impossível criar avaliação");
      }
    }
    return true;
  }

  Future<dynamic> atualizarAvaliacao(
      int id, Map<String, dynamic> payload) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacoes/$id");
      try {
        final response = await http.put(uri,
            headers: {
              "Accept": "application/json",
              HttpHeaders.authorizationHeader: "Bearer $token",
              HttpHeaders.contentTypeHeader: "application/json"
            },
            body: convert.json.encode(payload));

        if (response.statusCode == 200) {
          return AvaliacaoModel.fromJson(response.body);
        }
      } catch (e) {
        throw new Exception("Impossível realizar atualização");
      }
    }
    return true;
  }

  Future<dynamic> deletarAvaliacao(int id) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/avaliacoes/$id");
      try {
        final response = await http.delete(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

        if (response.statusCode == 204) {
          return true;
        }
      } catch (e) {
        throw new Exception("Impossível deletar avaliação");
      }
    }
    return true;
  }
}
