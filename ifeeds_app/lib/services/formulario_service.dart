import 'dart:html';

import 'package:ifeeds_app/models/feedback_model.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model.dart';

import 'envs.dart';
import 'package:http/http.dart' as http;
import 'dart:convert' as convert;

class FormularioService {
  
  static Future<dynamic> postFormulario(Map<String, dynamic>payload) async {
    Uri uri = Uri.http(Envs.baseUrl, "api/formularios-avaliacoes");
    try {
      print(convert.json.encode(payload));
      final response =
          await http.post(uri, headers: {
            "Content-Type": "application/json",
            "Accept": "application/json"
          }, body: convert.json.encode(payload));

      if (response.statusCode == 200) {
        return FormularioAvaliacaoModel.fromJson(response.body);

      }
    } catch (e) {
      throw new Exception("Impossível salvar formulário");
    }
  }
}