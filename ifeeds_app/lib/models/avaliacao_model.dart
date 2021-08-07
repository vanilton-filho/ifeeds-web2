import 'dart:convert';

class AvaliacaoModel {
  String? titulo;
  double? mediaAvaliacao;
  String? categoria;
  String? campus;
  int? totalFeedbacks;

  AvaliacaoModel({
    this.titulo,
    this.mediaAvaliacao,
    this.categoria,
    this.campus,
    this.totalFeedbacks,
  });

  Map<String, dynamic> toMap() {
    return {
      'titulo': titulo,
      'mediaAvaliacao': mediaAvaliacao,
      'categoria': categoria,
      'campus': campus,
      'totalFeedbacks': totalFeedbacks,
    };
  }

  factory AvaliacaoModel.fromMap(Map<String, dynamic> map) {
    return AvaliacaoModel(
      titulo: map['titulo'],
      mediaAvaliacao: map['mediaAvaliacao'],
      categoria: map['categoria'],
      campus: map['campus'],
      totalFeedbacks: map['totalFeedbacks'],
    );
  }

  String toJson() => json.encode(toMap());

  factory AvaliacaoModel.fromJson(String source) =>
      AvaliacaoModel.fromMap(json.decode(source));
}
