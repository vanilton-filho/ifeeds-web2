import 'dart:convert';

class RespostaFeedbackModel {
  int? id;
  String? titulo;
  String? descricao;
  String? resposta;
  String? codigo;
  int? feedbackId;
  double? nota;
  bool? status;
  String? usuario;

  RespostaFeedbackModel({
    this.id,
    this.titulo,
    this.descricao,
    this.resposta,
    this.codigo,
    this.feedbackId,
    this.nota,
    this.status,
    this.usuario,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'titulo': titulo,
      'descricao': descricao,
      'resposta': resposta,
      'codigo': codigo,
      'feedbackId': feedbackId,
      'nota': nota,
      'status': status,
      'usuario': usuario,
    };
  }

  factory RespostaFeedbackModel.fromMap(Map<String, dynamic> map) {
    return RespostaFeedbackModel(
      id: map['id'],
      titulo: map['titulo'],
      descricao: map['descricao'],
      resposta: map['resposta'],
      codigo: map['codigo'],
      feedbackId: map['feedbackId'],
      nota: map['nota'],
      status: map['status'],
      usuario: map['usuario'],
    );
  }

  String toJson() => json.encode(toMap());

  factory RespostaFeedbackModel.fromJson(String source) =>
      RespostaFeedbackModel.fromMap(json.decode(source));
}
