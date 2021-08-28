import 'dart:convert';

class RespostaFeedbackModel {

  String? titulo;
  
  String? descricao;

  String? resposta;

  double? nota;

  bool? status;

  String? usuario;
  RespostaFeedbackModel({
    this.titulo,
    this.descricao,
    this.resposta,
    this.nota,
    this.status,
    this.usuario,
  });

  
  

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'descricao': descricao,
      'resposta': resposta,
      'nota': nota,
      'status': status,
      'usuario': usuario,
    };
  }

  factory RespostaFeedbackModel.fromMap(Map<String, dynamic> map) {
    return RespostaFeedbackModel(
      titulo: map['titulo'],
      descricao: map['descricao'],
      resposta: map['resposta'],
      nota: map['nota'],
      status: map['status'],
      usuario: map['usuario'],
    );
  }

  String toJson() => json.encode(toMap());

  factory RespostaFeedbackModel.fromJson(String source) => RespostaFeedbackModel.fromMap(json.decode(source));
  }
