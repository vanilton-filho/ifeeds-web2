import 'dart:convert';

class FeedbackModelRequest {

  String? titulo;
  String? descricao;
  double? nota;
  int? avaliacaoId;
  int? usuarioId;

  FeedbackModelRequest({
    this.titulo,
    this.descricao,
    this.nota,
    this.avaliacaoId,
    this.usuarioId,
  });

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'descricao': descricao,
      'nota': nota,
      'avaliacaoId': avaliacaoId,
      'usuarioId': usuarioId,
    };
  }

  factory FeedbackModelRequest.fromMap(Map<String, dynamic> map) {
    return FeedbackModelRequest(
      titulo: map['titulo'],
      descricao: map['descricao'],
      nota: map['nota'],
      avaliacaoId: map['avaliacaoId'],
      usuarioId: map['usuarioId'],
    );
  }

  String toJson() => json.encode(toMap());

  factory FeedbackModelRequest.fromJson(String source) => 
    FeedbackModelRequest.fromMap(json.decode(source));
}
