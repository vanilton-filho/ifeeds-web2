import 'dart:convert' as convert;
import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/pages/utils/storage_util.dart';
import 'package:ifeeds_app/services/envs.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class CategoriaService {
  GetStorage storage = GetStorage();
  late final token;

  CategoriaService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> listarCategorias() async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias");
      await StorageUtil.getInstance();
      try {
        final response = await http.get(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

        if (response.statusCode == 200) {
          final json = convert.json.decode(response.body);
          print(json);
          return json
              .map<CategoriaModel>((json) => CategoriaModel.fromMap(json))
              .toList();
        }
        throw Exception();
      } catch (e) {
        throw new Exception("Impossível listar categorias");
      }
    }
    return true;
  }

  Future<dynamic> criarCategoria(Map<String, dynamic> payload) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias");
      try {
        final response = await http.post(uri,
            headers: {
              "Accept": "application/json",
              HttpHeaders.authorizationHeader: "Bearer $token",
              HttpHeaders.contentTypeHeader: "application/json"
            },
            body: convert.json.encode(payload));

        if (response.statusCode == 201) {
          return CategoriaModel.fromJson(response.body);
        }
      } catch (e) {
        throw new Exception("Impossível criar categoria");
      }
    }
    return true;
  }

  Future<dynamic> atualizarCategoria(
      int id, Map<String, dynamic> payload) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias/$id");
      try {
        final response = await http.put(uri,
            headers: {
              "Accept": "application/json",
              HttpHeaders.authorizationHeader: "Bearer $token",
              HttpHeaders.contentTypeHeader: "application/json"
            },
            body: convert.json.encode(payload));

        if (response.statusCode == 200) {
          return CategoriaModel.fromJson(response.body);
        }
      } catch (e) {
        throw new Exception("Impossível atualizar categoria");
      }
    }
    return true;
  }

  Future<dynamic> deletarCategoria(int id) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias/$id");
      print(uri);
      try {
        final response = await http.delete(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

        if (response.statusCode == 204) {
          return true;
        }
      } catch (e) {
        throw new Exception("Impossível deletar categoria");
      }
    }
    return true;
  }
}
