import 'dart:convert' as convert;
import 'dart:io';

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class CategoriaService {
  static Future<List<CategoriaModel>> listarCategorias() async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias");
    try {
      final response = await http.get(uri, headers: {
        "Accept": "application/json",
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

  static Future<dynamic> criarCategoria(Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/categorias");
    try {
      final response = await http.post(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json"
      }, body: convert.json.encode(payload));

      if (response.statusCode == 201) {
        final json = convert.json.decode(response.body);
        return CategoriaModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível criar categoria");
    }
  }

  static Future<dynamic> atualizarCategoria(
      Map<String, dynamic> payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/categoria");
    try {
      final response = await http.put(uri, headers: {
        HttpHeaders.acceptHeader: "application/json",
        HttpHeaders.contentTypeHeader: "application/json"
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return CategoriaModel.fromJson(json);
      }
    } catch (e) {
      throw new Exception("Impossível atualizar categoria");
    }
  }

  static Future<dynamic> deletarCategoria(int id) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/categoria/{id}");
    try {
      final response = await http.delete(uri);

      if (response.statusCode == 204) {
        return true;
      }
    } catch (e) {
      throw new Exception("Impossível deletar categoria");
    }
  }
}
