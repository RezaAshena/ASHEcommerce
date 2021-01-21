import { IProduct } from './product';

export interface IPagination {
  pageIndex: number;
  PageSize: number;
  count: number;
  data: IProduct[];

}

export class Pagination implements IPagination {
  pageIndex: number;
  PageSize: number;
  count: number;
  data: IProduct[] = [];
}
