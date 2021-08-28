import 'dart:convert' as convert;
import 'dart:io';

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/campus_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class CampusService {
  static Future<dynamic> criarCampus(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus");
    try {
      final response = await http.post(uri, headers: {
        HttpHeaders.acceptHeader:"application/json", HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 201) {
        final json = convert.json.decode(response.body);
        return CampusModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível criar campus");
    }
  }

  static Future<dynamic> atualizarCampus(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus");
    try {
      final response = await http.put(uri, headers: {
        HttpHeaders.acceptHeader:"application/json", HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return CampusModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar campus");
    }
  }

static Future<dynamic> deletarCampus(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/campus/{id}");
    try {
      final response = await http.delete(uri);

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar campus");
    }
  }



}
