import 'dart:convert' as convert;

import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/estatistica_model.dart';
import 'package:ifeeds_app/services/envs.dart';

class EstatisticaService {
  static Future<dynamic> getEstatisticas(int usuarioId) async {
    Uri uri = Uri.http(Envs.baseUrl, "v1/api/estatisticas/$usuarioId");
    try {
      final response =
          await http.get(uri, headers: {"Accept": "application/json"});

      if (response.statusCode == 200) {
        //final json = convert.json.decode(response.body);
        print(response.body);
        return EstatisticaModel.fromJson(response.body);
      }
    } catch (e) {
      throw new Exception("Impossível listar estatísticas");
    }
  }
}
