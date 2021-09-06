import 'dart:io';

import 'package:get_storage/get_storage.dart';
import 'package:http/http.dart' as http;
import 'package:ifeeds_app/models/estatistica_model.dart';
import 'package:ifeeds_app/services/envs.dart';
import 'package:ifeeds_app/services/jwt_utils.dart';

class EstatisticaService {
  GetStorage storage = GetStorage();
  late final token;

  EstatisticaService() {
    this.token = storage.read("jwt");
  }

  Future<dynamic> getEstatisticas(int usuarioId) async {
    if (!(JwtUtils.isExpired(storage))) {
      Uri uri = Uri.http(Envs.baseUrl, "v1/api/estatisticas/$usuarioId");
      try {
        final response = await http.get(uri, headers: {
          "Accept": "application/json",
          HttpHeaders.authorizationHeader: "Bearer $token"
        });

        if (response.statusCode == 200) {
          //final json = convert.json.decode(response.body);
          return EstatisticaModel.fromJson(response.body);
        }
      } catch (e) {
        throw new Exception("Impossível listar estatísticas");
      }
    }
    return true;
  }
}
