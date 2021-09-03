import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class CampusService {
  GetStorage storage = GetStorage();
  late final token;

  CampusService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> listarCampus() async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus");
    try {
      final response = await http.get(uri,  headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<CampusModel>((json) => CampusModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar campus");
    }
  }

  Future<dynamic> criarCampus(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus");
    try {
      final response = await http.post(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
       }, body: convert.json.encode(payload));

      if (response.statusCode == 201) {
        return CampusModel.fromJson(response.body);
      }
    } catch (e) {
      throw new Exception("Impossível criar campus");
    }
  }

  Future<dynamic> atualizarCampus(int id, Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus/$id");
    try {
      final response = await http.put(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      }, body: convert.json.encode(payload));

      if (response.statusCode == 200) {
        return CampusModel.fromJson(response.body);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar campus");
    }
  }

  Future<dynamic> deletarCampus(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus/$id");
    try {
      final response = await http.delete(uri, headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token"
      });

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar campus");
    }
  }
}
