import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/usuario_model.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

import 'envs.dart';

class UsuarioService {
  GetStorage storage = GetStorage();
  late final token;

  UsuarioService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> cadastrar(Map<String, dynamic> payload) async {
    if (!(JwtUtils.isExpired(storage))) {
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
    return true;
  }

  Future<dynamic> getPorMatricula(String matricula) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios/$matricula");
      try {
        final response = await http.get(
          uri,
          headers: {
            "Accept": "application/json",
            HttpHeaders.authorizationHeader: "Bearer $token",
          },
        );

        if (response.statusCode == 200) {
          return UsuarioModel.fromJson(response.body);
        }
      } catch (e) {
        throw Exception("Indisponível obter usuário");
      }
    }
    return true;
  }

  Future<dynamic> listar() async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios");
      try {
        final response = await http.get(
          uri,
          headers: {
            "Accept": "application/json",
            HttpHeaders.authorizationHeader: "Bearer $token",
          },
        );

        if (response.statusCode == 200) {
          final json = convert.json.decode(response.body);
          return json
              .map<UsuarioModel>((json) => UsuarioModel.fromMap(json))
              .toList();
        }
      } catch (e) {
        throw Exception("Indisponível listar usuário");
      }
    }
    return true;
  }

  Future<bool?> ativar(String matricula) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios/$matricula/ativar");
      try {
        final response = await http.put(
          uri,
          headers: {
            "Accept": "application/json",
            HttpHeaders.authorizationHeader: "Bearer $token",
          },
        );

        if (response.statusCode == 204) {
          return true;
        }
      } catch (e) {
        throw Exception("Indisponível ativar usuário");
      }
    }
    return true;
  }

  Future<bool?> desativar(String matricula) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/usuarios/$matricula/desativar");
      try {
        final response = await http.delete(
          uri,
          headers: {
            "Accept": "application/json",
            HttpHeaders.authorizationHeader: "Bearer $token",
          },
        );

        if (response.statusCode == 204) {
          return true;
        }
      } catch (e) {
        throw Exception("Indisponível desativar usuário");
      }
    }
    return true;
  }
}
