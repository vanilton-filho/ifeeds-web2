import 'dart:convert';

class EstatisticaModel {
  int? quantidadeFeedbacks;

  int? feedbacksSemResposta;

  int? feedbacksRespondidos;

  double? satisfacaoGeral;
  
  EstatisticaModel({
    this.quantidadeFeedbacks,
    this.feedbacksSemResposta,
    this.feedbacksRespondidos,
    this.satisfacaoGeral,
  });

  Map<String, dynamic> toMap() {
    return {
      'quantidadeFeedbacks': quantidadeFeedbacks,
      'feedbacksSemResposta': feedbacksSemResposta,
      'feedbacksRespondidos': feedbacksRespondidos,
      'satisfacaoGeral': satisfacaoGeral,
    };
  }

  factory EstatisticaModel.fromMap(Map<String, dynamic> map) {
    return EstatisticaModel(
      quantidadeFeedbacks: map['quantidadeFeedbacks'],
      feedbacksSemResposta: map['feedbacksSemResposta'],
      feedbacksRespondidos: map['feedbacksRespondidos'],
      satisfacaoGeral: map['satisfacaoGeral'],
    );
  }

  String toJson() => json.encode(toMap());

  factory EstatisticaModel.fromJson(String source) => EstatisticaModel.fromMap(json.decode(source));
}
