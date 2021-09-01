import 'dart:convert';

import 'package:ifeeds_app/models/feedback_avaliacao_model.dart';
import 'package:intl/intl.dart';

class FeedbackModel {
  int? id;
  String? codigo;
  String? titulo;
  String? descricao;
  String? matricula;
  double? nota;
  FeedbackAvaliacaoModel? avaliacao;
  String? campus;
  String? resposta;
  bool? status;
  DateTime? dataCriacao;
  DateTime? dataResposta;

  FeedbackModel({
    this.id,
    this.codigo,
    this.titulo,
    this.descricao,
    this.matricula,
    this.nota,
    this.avaliacao,
    this.campus,
    this.resposta,
    this.status,
    this.dataCriacao,
    this.dataResposta,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'codigo': codigo,
      'titulo': titulo,
      'descricao': descricao,
      'matricula': matricula,
      'nota': nota,
      'avaliacao': avaliacao?.toMap(),
      'campus': campus,
      'resposta': resposta,
      'status': status,
      'dataCriacao': new DateFormat("yy-MM-dd").format(dataCriacao!),
      'dataResposta': dataResposta == null
          ? null
          : new DateFormat("yy-MM-dd").format(dataCriacao!),
    };
  }

  factory FeedbackModel.fromMap(Map<String, dynamic> map) {
    return FeedbackModel(
      id: map['id'],
      codigo: map['codigo'],
      titulo: map['titulo'],
      descricao: map['descricao'],
      matricula: map['matricula'],
      nota: map['nota'],
      avaliacao: FeedbackAvaliacaoModel.fromMap(map['avaliacao']),
      campus: map['campus'],
      resposta: map['resposta'],
      status: map['status'],
      dataCriacao: DateFormat('yy-MM-dd').parse(map['dataCriacao']),
      dataResposta: map['dataResposta'] == null
          ? null
          : DateFormat('yy-MM-dd').parse(map['dataResposta']),
    );
  }

  factory FeedbackModel.fromJson(String source) =>
      FeedbackModel.fromMap(json.decode(source));
}
