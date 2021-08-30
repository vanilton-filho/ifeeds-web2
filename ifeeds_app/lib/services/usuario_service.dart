import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/usuario_model.dart';

import 'envs.dart';


class UsuarioService {
  GetStorage storage = GetStorage();
  late final token;

  UsuariosService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> cadastrar(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios");
    try {
      final response = await http.post(uri,
          headers: {
        "Accept": "application/json",
        HttpHeaders.authorizationHeader: "Bearer $token",
        HttpHeaders.contentTypeHeader: "application/json"
      },
          body: convert.json.encode(payload));

      if (response.statusCode == 201) {
        return UsuarioModel.fromJson(response.body);
      } 
    } catch (e) {
      throw Exception("Indisponível realizar login");
    }
  }
}
