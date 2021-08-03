import 'dart:convert' as convert;

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/avaliacao_model.dart';
import 'package:ifeeds_app/models/categoria_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class AvaliacaoService {
  static Future<dynamic> listarAvaliacoes() async {
    Uri uri = Uri.http(Envs.baseUrl, "api/avaliacoes");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

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

  static Future<dynamic> listarAvaliacoesPorCategoria(int categoria) async {
    Uri uri =
        Uri.http(Envs.baseUrl, "api/avaliacoes/$categoria/por-categoria");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

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

  static Future<dynamic> listarCategorias() async {
    Uri uri = Uri.http(Envs.baseUrl, "api/categorias");
    try {
      final response = await http.get(uri, headers: {
        "Accept": "application/json",
      });

      if (response.statusCode == 200) {
        final json = convert.json.decode(response.body);
        return json
            .map<CategoriaModel>((json) => CategoriaModel.fromMap(json))
            .toList();
      }
    } catch (e) {
      throw new Exception("Impossível listar categorias");
    }
  }
}
