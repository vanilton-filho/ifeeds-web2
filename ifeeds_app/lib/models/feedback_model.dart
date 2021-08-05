import 'dart:convert';

import 'package:ifeeds_app/models/feedback_avaliacao_model.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model.dart';
import 'package:intl/intl.dart';

class FeedbackModel {
  
  String? codigo;
  String? matricula;
  double? nota;
  DateTime? dataCriacao;

  FormularioAvaliacaoModel? formulario;
  FeedbackAvaliacaoModel? avaliacao;
  FeedbackModel({
    this.codigo,
    this.matricula,
    this.nota,
    this.dataCriacao,
    this.formulario,
    this.avaliacao,
  });
  
  Map<String, dynamic> toMap() {
    return {
      'codigo': codigo,
      'matricula': matricula,
      'nota': nota,
      'dataCriacao': new DateFormat("yy-MM-dd").format(dataCriacao!),
      'formulario': formulario?.toMap(),
      'feedback': avaliacao?.toMap(),
    };
  }

  factory FeedbackModel.fromMap(Map<String, dynamic> map) {
    return FeedbackModel(
      codigo: map['codigo'],
      matricula: map['matricula'],
      nota: map['nota'],
      dataCriacao: DateFormat('yy-MM-dd').parse(map['dataCriacao']),
      formulario: FormularioAvaliacaoModel.fromMap(map['formulario']),
      avaliacao: FeedbackAvaliacaoModel.fromMap(map['avaliacao']),
    );
  }

  String toJson() => json.encode(toMap());

  factory FeedbackModel.fromJson(String source) => FeedbackModel.fromMap(json.decode(source));
}
