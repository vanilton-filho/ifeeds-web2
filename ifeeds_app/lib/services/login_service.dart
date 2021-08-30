import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/error_model.dart';
import 'package:ifeeds_app/services/envs.dart';
import 'package:jwt_decoder/jwt_decoder.dart';

class LoginService {
  /// Realiza o login do usuário e retorna
  /// as informações do usuário juntamente com o token JWT.
  /// [payload] O objeto que será enviado
  Future<dynamic> login(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios/login");
    try {
      final response = await http.post(uri,
          headers: {
            "Content-Type": "application/json",
            "Accept": "application/json",
            HttpHeaders.allowHeader: "Authorization",
            HttpHeaders.contentTypeHeader: "application/json"
          },
          body: convert.json.encode(payload));

      if (response.statusCode == 204) {
        GetStorage storage = GetStorage();
        await storage.write("jwt", response.headers["authorization"].toString());
        Map<String, dynamic> decodedToken =
            JwtDecoder.decode(storage.read("jwt"));
        return decodedToken["role"];
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
