import 'dart:convert';

class FeedbackAvaliacaoModel {
    int? id;
    String? titulo;
    
  FeedbackAvaliacaoModel({
    this.id,
    this.titulo,
  });

  Map<String, dynamic> toMap() {
    return {
      'id': id,
      'titulo': titulo,
    };
  }

  factory FeedbackAvaliacaoModel.fromMap(Map<String, dynamic> map) {
    return FeedbackAvaliacaoModel(
      id: map['id'],
      titulo: map['titulo'],
    );
  }

  String toJson() => json.encode(toMap());

  factory FeedbackAvaliacaoModel.fromJson(String source) => FeedbackAvaliacaoModel.fromMap(json.decode(source));
}
