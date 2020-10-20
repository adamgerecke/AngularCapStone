import { Component } from '@angular/core';
import { DALService } from 'src/DAL.service';
import { QandA} from '../interfaces/IQandA';

@Component({
    selector: 'app-qand-a',
    templateUrl: './qand-a.component.html',
    styleUrls: ['./qand-a.component.css']
})
/** QandA component*/
export class QandAComponent {
/** QandA ctor */

  qandalist;

  constructor(private dal: DALService) { }

  ngOnInit(): void {
    this.dal.getAllQandA().subscribe(
      (data: QandA) =>
        this.qandalist = data
    );
    console.log(this.dal.getAllQandA());
    }
}
