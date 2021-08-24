import 'dart:convert' as convert;

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/usuario_model.dart';

import 'envs.dart';


class UsuarioService {

  static Future<dynamic> cadastrar(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios");
    try {
      final response = await http.post(uri,
          headers: {
            "Content-Type": "application/json",
            "Accept": "application/json"
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
