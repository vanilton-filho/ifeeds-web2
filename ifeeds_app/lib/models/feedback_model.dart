import 'dart:convert';

import 'package:intl/intl.dart';

import 'package:ifeeds_app/models/feedback_avaliacao_model.dart';
import 'package:ifeeds_app/models/formulario_avaliacao_model.dart';

class FeedbackModel {
  
  String? codigo;
  String? matricula;
  double? nota;
  DateTime? dataCriacao;
  String? campus;
  FormularioAvaliacaoModel? formulario;
  FeedbackAvaliacaoModel? avaliacao;
  bool? status;
  String? resposta;
  DateTime? dataResposta;

  FeedbackModel({
    this.codigo,
    this.matricula,
    this.nota,
    this.dataCriacao,
    this.campus,
    this.formulario,
    this.avaliacao,
    this.status,
    this.resposta,
    this.dataResposta,
  });
  
  Map<String, dynamic> toMap() {
    return {
      'codigo': codigo,
      'matricula': matricula,
      'nota': nota,
      'campus': campus,
      'dataCriacao': new DateFormat("yy-MM-dd").format(dataCriacao!),
      'formulario': formulario?.toMap(),
      'feedback': avaliacao?.toMap(),
      'status': status,
      'resposta': resposta,
      'dataResposta': dataResposta == null ? null : new DateFormat("yy-MM-dd").format(dataCriacao!),
    };
  }

  factory FeedbackModel.fromMap(Map<String, dynamic> map) {
    return FeedbackModel(
      codigo: map['codigo'],
      matricula: map['matricula'],
      nota: map['nota'],
      campus: map['campus'],
      dataCriacao: DateFormat('yy-MM-dd').parse(map['dataCriacao']),
      formulario: FormularioAvaliacaoModel.fromMap(map['formulario']),
      avaliacao: FeedbackAvaliacaoModel.fromMap(map['avaliacao']),
      status: map['status'],
      resposta: map['resposta'],
      dataResposta: map['dataResposta'] == null ? null : DateFormat('yy-MM-dd').parse(map['dataResposta']),
    );
  }

  String toJson() => json.encode(toMap());

  factory FeedbackModel.fromJson(String source) => FeedbackModel.fromMap(json.decode(source));
}
