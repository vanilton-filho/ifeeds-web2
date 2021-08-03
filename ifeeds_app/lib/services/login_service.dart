import 'dart:convert' as convert;

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/error_model.dart';
import 'package:ifeeds_app/models/login_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class LoginService {
  /// Realiza o login do usuário e retorna
  /// as informações do usuário juntamente com o token JWT.
  /// [payload] O objeto que será enviado
  Future<dynamic> login(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "api/usuarios/login");
    try {
      final response = await http.post(uri,
          headers: {
            "Content-Type": "application/json",
            "Accept": "application/json"
          },
          body: convert.json.encode(payload));

      if (response.statusCode == 200) {
        return UsuarioLoginModel.fromJson(response.body);
      } else if (response.statusCode == 404) {
        return ErrorModel(
          statusCode: response.statusCode,
          message: 'A matrícula ou email estão errados.',
        );
      } else if (response.statusCode == 500) {
        return ErrorModel(
          statusCode: response.statusCode,
          message: 'Aconteceu algum erro interno no servidor.',
        );
      }
    } catch (e) {
      throw Exception("Indisponível realizar login");
    }
  }
}
